using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG2_Assignment
{
    class BoardingGate
    {
        public string GateName { get; set; }
        public bool SupportsCFFT { get; set; }
        public bool SupportsDDJB { get; set; }
        public bool SupportsLWTT {  get; set; }
        public Flight Flight { get; set; }

        public double CalculateFees()
        {
            double basefee = 300;
            if (SupportsCFFT == true)
            {
                basefee += 150;
            }
            else if (SupportsDDJB == true)
            {
                basefee += 300;
            }
            else if (SupportsLWTT == true)
            {
                basefee += 500;
            }

            return basefee;
        }

        public BoardingGate() { }
        public BoardingGate(string _gatename, bool _supportscfft, bool _supportsddjb, bool _supportslwtt, Flight _flight)
        {
            GateName = _gatename;
            SupportsCFFT = _supportscfft;
            SupportsDDJB = _supportsddjb;
            SupportsLWTT = _supportslwtt;
            Flight = _flight;
            
        }

        public override string ToString()
        {
            return $"Gate name: {GateName,-10}, CFFT: {SupportsCFFT,-10}, DDJB: {SupportsDDJB,-10}, LWTT: {SupportsLWTT,-10}, Flight: {Flight}";
        }

    }//ending class brack 
}//ending ns brack
