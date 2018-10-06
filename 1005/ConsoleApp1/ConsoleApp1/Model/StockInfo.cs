using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Model
{
    class StockInfo
    {
        #region Variable
        private string _date;
        private string _id;
        private string _name;
        private string _close;
        private string _advanceDeclin;
        private string _open;
        private string _dayhigh;
        private string _daylow;
        private string _totalStockVolume;
        private string _totalDollarCount;
        private string _totalCount;
        private string _lastBuying;
        private string _lastSelling;
        private string _pulishStockCount;
        private string _limitUpPrice;
        private string _limitDownPrice;
        #endregion

        #region Constructor
        public StockInfo() { }
        #endregion

        #region Property
        public string Date
        {
            set
            {
                _date = value;
            }
            get
            {
                return _date;
            }
        }

        public string ID
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }

        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public string Close
        {
            set
            {
                _close = value;
            }
            get
            {
                return _close;
            }
        }

        public string AdvanceDeclin
        {
            set
            {
                _advanceDeclin = value;
            }
            get
            {
                return _advanceDeclin;
            }
        }

        public string Open
        {
            set
            {
                _open = value;
            }
            get
            {
                return _open;
            }
        }

        public string Dayhigh
        {
            set
            {
                _dayhigh = value;
            }
            get
            {
                return _dayhigh;
            }
        }

        public string Daylow
        {
            set
            {
                _daylow = value;
            }
            get
            {
                return _daylow;
            }
        }

        public string TotalStockVolume
        {
            set
            {
                _totalStockVolume = value;
            }
            get
            {
                return _totalStockVolume;
            }
        }

        public string TotalDollarCount
        {
            set
            {
                _totalDollarCount = value;
            }
            get
            {
                return _totalDollarCount;
            }
        }

        public string TotalCount
        {
            set
            {
                _totalCount = value;
            }
            get
            {
                return _totalCount;
            }
        }

        public string LastBuying
        {
            set
            {
                _lastBuying = value;
            }
            get
            {
                return _lastBuying;
            }
        }

        public string LastSelling
        {
            set
            {
                _lastSelling = value;
            }
            get
            {
                return _lastSelling;
            }
        }

        public string PulishStockCount
        {
            set
            {
                _pulishStockCount = value;
            }
            get
            {
                return _pulishStockCount;
            }
        }

        public string LimitUpPrice
        {
            set
            {
                _limitUpPrice = value;
            }
            get
            {
                return _limitUpPrice;
            }
        }

        public string LimitDownPrice
        {
            set
            {
                _limitDownPrice = value;
            }
            get
            {
                return _limitDownPrice;
            }
        }

        #endregion
    }
}
