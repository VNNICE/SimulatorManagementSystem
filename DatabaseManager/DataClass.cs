using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager
{
    class SimulatorList
    {
        public string _Id { get; set; }

        public int _Width { get; set; }
        public int _Depth { get; set; }
        public int _Height { get; set; }
        public int _CBM { get; set; }
        public int _Voltage { get; set; }
        public int _Hz { get; set; }
        public DateOnly _MFGDate { get; set; }
        public string _Memo { get; set; }
        public SimulatorList(string id, int width, int depth, int height, int cbm, int voltage, int hz, DateOnly mfgDate, string memo)
        {
            _Id = id;
            _Width = width;
            _Depth = depth;
            _Height = height;
            _CBM = cbm;
            _Voltage = voltage;
            _Hz = hz;
            _MFGDate = mfgDate;
            _Memo = memo;
        }
    }

    class Storage 
    {
        
    }

    class CityList 
    {
        
    }
}