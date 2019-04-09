using System;

namespace HeadFirst.DesignPatterns.Facade
{

    public class Amplifier
    {
        private string _description;
        private Tuner _tuner;
        private DvdPlayer _dvd;
        private CdPlayer _cd;

        public Amplifier(string description)
        {
            _description = description;
        }

        public void On()
        {
            Console.WriteLine($"{_description} on");
        }

        public void Off()
        {
            Console.WriteLine($"{_description} off");
        }

        public void SetStereoSound()
        {
            Console.WriteLine($"{_description} stereo mode on");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine($"{_description} surround sound on (5 speakers, 1 subwoofer)");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine($"{_description} setting volume to {level}");
        }

        public void SetTuner(Tuner tuner)
        {
            Console.WriteLine($"{_description} setting tuner to {_dvd}" );
            _tuner = tuner;
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine($"{_description} setting DVD player to {_dvd}" );
            _dvd = dvd;
        }

        public void SetCd(CdPlayer cd)
        {
            Console.WriteLine($"{_description} setting CD player to {_cd}");
            _cd = cd;
        }

        public override string ToString()
        {
            return _description;
        }
    }
}