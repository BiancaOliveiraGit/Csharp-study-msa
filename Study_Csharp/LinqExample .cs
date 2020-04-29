using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_Csharp
{
    public static class LinqExample
    {
        public  struct ListOfSurfaces
        {
            public int Id;
            public string surface;
            public string side;
        }

        static public string MatchIdForSurface(int selectId,string selectSide)
        {
            string matchedStr = "";

            try
            {
                var listSurface = new List<ListOfSurfaces>();
                ListOfSurfaces surface1 = new ListOfSurfaces { Id = 1, surface = "plaster",side= "SIDEA" };
                listSurface.Add(surface1);
                ListOfSurfaces surface2 = new ListOfSurfaces { Id = 2, surface = "general", side = "SIDEA" };
                listSurface.Add(surface2);
                ListOfSurfaces surface3 = new ListOfSurfaces { Id = 3, surface = "face brick", side = "SIDEB" };
                listSurface.Add(surface3);
                ListOfSurfaces surface4 = new ListOfSurfaces { Id = 4, surface = "plaster", side = "SIDEB" };
                listSurface.Add(surface4);
                ListOfSurfaces surface5 = new ListOfSurfaces { Id = 2, surface = "render", side = "SIDEB" };
                listSurface.Add(surface5);

                //var match = listSurface.Where(c => c.Id == selectId && c.side == selectSide)
                //                    .Select(c => c.surface).FirstOrDefault();
                var match = listSurface.Where(c => c.Id == selectId && c.side.Contains(selectSide) == true)
                                  .Select(c => c.surface).FirstOrDefault();

                if (match != null)
                {
                    matchedStr = match;
                }
            }
            catch (Exception e)
            {
                matchedStr = e.Message.ToString();
            }

            return matchedStr;
        }

    }
}
