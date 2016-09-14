using MetroFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ForYourEyes.CoreFunctionality
{
    [Serializable]
    class ProfileFileManager
    {
        public int ActiveProfileNumber { get; set; }
        public List<Profile> Profiles { get; set; }
        
        public void Save(int _ActiveProfileNumber, List<Profile> _Profiles)
        {
            ProfileFileManager pfm = new ProfileFileManager();
            pfm.ActiveProfileNumber = _ActiveProfileNumber;
            pfm.Profiles = _Profiles;
            try
            {
                using (Stream stream = File.Open("data.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, pfm);
                    stream.Close();
                }
            }
            catch (IOException)
            {
            }
        }

        public ProfileFileManager Read()
        {
            Stream stream = File.Open("data.bin", FileMode.OpenOrCreate);
            if (stream.Length == 0)
            {
                Profile Default = new Profile(
                    "Domyślny",
                    new Settings(4, 10, 55, 5),
                    new List<Break>{
                            new Break("Zamknij oczy.", "1"), 
                            new Break("Przesuwaj oczy w prawo i lewo.", "2"),
                            new Break("Zamrugaj kilka razy.", "3"),
                            new Break("Skoncentruj wzrok na dalekim obiekcie (np. za oknem)", "4")},
                    new ApplicationLook(MetroThemeStyle.Light, MetroColorStyle.Blue, 75),
                    new Sound(true));
                List<Profile> ProfilesDefault = new List<Profile>();
                ProfilesDefault.Add(Default);
                stream.Close();
                Save(0, ProfilesDefault);
            }
            else stream.Close();
            using (stream = File.Open("data.bin", FileMode.OpenOrCreate))
            {
                BinaryFormatter bin = new BinaryFormatter();
                return (ProfileFileManager)bin.Deserialize(stream);
            }
        }
    }
}
