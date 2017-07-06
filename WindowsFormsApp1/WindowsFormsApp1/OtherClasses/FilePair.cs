using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.OtherClasses
{
    class FilePair<Name, FullPath,Change>
    {
        Name file_name;
        FullPath file_path;
        Change file_change_reason;  //Created ,deleted ,changed 

        //Counstructor
        public FilePair(Name file_name,FullPath file_path,Change file_change_reason)
        {
            this.file_name = file_name;
            this.file_path = file_path;
            this.file_change_reason = file_change_reason;
        }

        //Getter setters
        public Name getName()
        {          
            return file_name;
        }
        
        public FullPath getPath()
        {
            return file_path;
        }

        public Change getChangeReason()
        {
            return file_change_reason;
        }

        override
        public string ToString()
        {
            return "Pair->[ Name : "+file_name+" Path : "+file_path+" Change Reason : "+file_change_reason+" ]";
        }

        //Sub Methods
        public static FilePair<Name, FullPath,Change>CreatePair(Name file_name, FullPath file_path, Change file_change_reason)
        {
            return new FilePair<Name,FullPath,Change>(file_name, file_path, file_change_reason);
        }

    }
}
