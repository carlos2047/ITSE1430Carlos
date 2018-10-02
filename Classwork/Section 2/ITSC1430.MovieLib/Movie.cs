using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSC1430.MovieLib
{
    public class Movie
    {
        public string Name
        {
            get { return _name ?? ""; }   //string get ()
            set { _name = value; }  //void set ( string value )
        }
        //public string GetName()
        //{
        //    return _name ?? "";
        //}
        //public void SetName (string value)
        //{
        //    _name = value;
        //}
        private string _name = "";

        //public System.String Name;

            public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        
        private string _description;

        public int ReleaseYear { get; set; } = 1900;

       // private int _releaseYear = 1900;

        public int RunLength { get; set; }

        //showing mixed accessibility
        public int Id { get; private set; }
        public bool isColor
        {
            get { return ReleaseYear > 1940; }
        }    
    }
}
