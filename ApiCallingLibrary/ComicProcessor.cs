using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiCallingLibrary
{
   public class ComicProcessor
    {
        public static async Task<ComicModel> LoadComic(int comicNumber = 0)
        {
            string url = "";

            if (comicNumber > 0)
            {
                url = $"Https://xkcd.com/{ comicNumber }/info.0.json";
            }
            else
            {
                url = $"Https://xkcd.com/info.0.json";
            }

            using (HttpResponseMessage response=await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    ComicModel comic = await response.Content.ReadAsAsync<ComicModel>();

                    return comic;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
