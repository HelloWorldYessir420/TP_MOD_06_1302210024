using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD_06_1302210024
{
    internal class sayaTubevideo
    {
        private int Id;
        private string Title;
        private int PlayCount;

        public sayaTubevideo(string title)
        {
            if (title == null)
            {
                throw new ArgumentNullException("Judul video tidak boleh null.");
            }
            if (title.Length > 100)
            {
                throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter.");
            }

            this.Id = new Random().Next(10000, 99999);
            this.Title = title;
            this.PlayCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 10000000)
            {
                throw new ArgumentException("Input penambahan play count harus di antara 0 dan 10.000.000.");
            }

            try
            {
                checked
                {
                    this.PlayCount += count;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.Id);
            Console.WriteLine("Title: " + this.Title);
            Console.WriteLine("Play Count: " + this.PlayCount);
        }
    }
}
