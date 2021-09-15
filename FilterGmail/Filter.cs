using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterGmail
{
    class Filter
    {        
        public HashSet<string> fromList { get; set; }
        public HashSet<string> isList { get; set; }

        public HashSet<String> subjects { get; set; }

        public Filter()
        {
            fromList = new HashSet<string>();
            isList = new HashSet<string>();
            subjects = new HashSet<string>();
        }

        public string generateFrom()
        {
            bool isFirst = true;
            if (fromList == null || fromList.Count == 0) return "";
            string fromFilter = "from:(";
            foreach (var email in fromList)
            {
                if (isFirst) fromFilter += "\"" + email + "\"";
                else fromFilter = fromFilter + " OR " + "\"" + email + "\"";
                isFirst = false;
            }
            fromFilter += ")";
            return fromFilter;
        }

        public string generateIs()
        {
            if (isList == null || isList.Count == 0) return "";

            string isFilter = "";
            foreach (var item in isList)
            {
                isFilter += item.ToString() + " ";
            }
            return isFilter;
        }

        public string generateSubject()
        {
            bool isFirst = true;
            if (subjects == null || subjects.Count == 0) return "";
            string subjectstr = "subject:(";
            foreach (var subject in subjects)
            {
                if (isFirst) subjectstr += "\"" + subject + "\"";
                else subjectstr += " OR " + "\"" + subject + "\"";
                isFirst = false;
            }
            subjectstr += ")";
            return subjectstr;
        }

        public void Clear()
        {
            this.fromList.Clear();
            this.isList.Clear();
            this.subjects.Clear();
        }
    }
}
