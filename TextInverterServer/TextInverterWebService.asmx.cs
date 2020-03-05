using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace TextInverterServer
{
    /// <summary>
    /// Summary description for TextInverterWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TextInverterWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string TextInverter(string inputstring)
        {

            string result = string.Concat(Regex
    .Split(inputstring, @"(\W+)") // split on not word letter, separator preserved
    .Select(letter => letter.Length > 0 && char.IsLetter(letter[0])
       ? string.Concat(letter.Reverse()) // reverse letter
       : letter));

            //Anoter way
            //            char[] inpchar = inputstring.ToCharArray();
            //            List<int> spaceindx = new List<int>();
            //            string res = "";
            //            string res1 = "";
            //            string space = " ";
            //            int k = 0;
            //            StringBuilder sb = new StringBuilder();
            //            for (int i= 0; i<inputstring.Length;i++)
            //            {
            //                if (inpchar[i].Equals(' ') )
            //                {
            //                    spaceindx.Add(i);

            //                }

            //            }

            //            for (int j = 0; j < spaceindx.Count; j++)
            //            {
            //                if (k == spaceindx[j])
            //                    res = res+space;
            //                else
            //                {

            //                    res1 = new string((inputstring.Substring(k, spaceindx[j] - k)).Reverse().ToArray()) + space;
            //                    res = res + res1;
            //                }
            //                k = spaceindx[j] + 1;
            //                if(inputstring.Length>=k)
            //                if (j == (spaceindx.Count - 1))
            //                {
            //                    res1 = new string((inputstring.Substring(k, (inputstring.Length)-k)).Reverse().ToArray());
            //                    res = res + res1;
            //                }
            //            }
            //            return res;

            return result;

        }
    }
}
