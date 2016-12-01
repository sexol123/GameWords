using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWords
{
  public class Datal
    {
        public Dictionary<string,string> dictre = new Dictionary<string, string>();

      public void SetData()
      {
          dictre.Add("собака","dog");
            dictre.Add("Мужчина","Man");
            dictre.Add("Женщина","Women");
            dictre.Add("Авто","Car");
            dictre.Add("Яблоко","Apple");
            dictre.Add("Любовь","Love");
      }

      public override string ToString()
      {
          return base.ToString();
      }
    }
}
