using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyAlert
{
    internal class weatherData
    {
        int tempretaura, mogucnostKise, vjetar, vlaznostZraka, uvIndeks;

        public weatherData(int tempretaura, int mogucnostKise, int vjetar, int vlaznostZraka, int uvIndeks)
        {
            this.tempretaura = tempretaura;
            this.mogucnostKise = mogucnostKise;
            this.vjetar = vjetar;
            this.vlaznostZraka = vlaznostZraka;
            this.uvIndeks = uvIndeks;
        }

        public int Tempretaura { get => tempretaura; set => tempretaura = value; }
        public int MogucnostKise { get => mogucnostKise; set => mogucnostKise = value; }
        public int Vjetar { get => vjetar; set => vjetar = value; }
        public int VlaznostZraka { get => vlaznostZraka; set => vlaznostZraka = value; }
        public int UvIndeks { get => uvIndeks; set => uvIndeks = value; }
    }
}
