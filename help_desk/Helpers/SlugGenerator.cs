using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace help_desk.Helpers
{
    public static class SlugGenerator
    {
        public static string GenerateSlug(this string phrase)
        {

            //Чтобы было проще переводим в нижний регистр:
            phrase = phrase.ToLower();
            //Переводим в код (с кодировкой Default):
            byte[] b = System.Text.Encoding.Default.GetBytes(phrase);
            //Проверяем так:
            int russ_count = 0;
            foreach (byte bt in b)
            {
                if ((bt >= 192) && (bt <= 239)) russ_count++;
            }
            if (russ_count > 0) { phrase = Translit(phrase); }

            string str = phrase.RemoveAccent();
            // invalid chars           
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // convert multiple spaces into one space   
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // cut and trim 
            str = str.Substring(0, str.Length <= 45 ? str.Length : 45).Trim();
            str = Regex.Replace(str, @"\s", "-"); // hyphens   
            return str;
        }
        public static string RemoveAccent(this string txt)
        {
            byte[] bytes = System.Text.Encoding.GetEncoding("UTF-8").GetBytes(txt);
            return System.Text.Encoding.ASCII.GetString(bytes);
        }
        private static string Translit(string s)
        {
            string ret = "";
            string[] rus = {"а","б","в","г","д","е","ё","ж", "з","и","й","к","л","м", "н",
          "о","п","р","с","т","у","ф","х", "ц", "ч", "ш", "щ",   "ъ", "ы","ь",
          "э","ю", "я" };
            string[] eng = {"a","b","v","g","d","e","e","zh","z","i","y","k","l","m","n",
          "o","p","r","s","t","u","f","kh","ts","ch","sh","shch",null,"y",null,
          "e","yu","ya"};

            for (int j = 0; j < s.Length; j++)
                for (int i = 0; i < rus.Length; i++)
                    if (s.Substring(j, 1) == rus[i]) ret += eng[i];

            return ret;
        }
    }
}