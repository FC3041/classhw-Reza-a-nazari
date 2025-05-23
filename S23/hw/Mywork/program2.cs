using System.IO;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program2
{
    static async Task Main(string[] args)
    {
        using var client = new HttpClient();
        string newsUrl = "https://www.tabnak.ir/fa/news/1307013/%D9%85%D8%B0%D8%A7%DA%A9%D8%B1%D8%A7%D8%AA-%D8%A7%DB%8C%D8%B1%D8%A7%D9%86-%D9%88-%D8%A2%D9%85%D8%B1%DB%8C%DA%A9%D8%A7-%D8%A8%D9%87-%D8%A7%DB%8C%D8%B3%D8%AA%DA%AF%D8%A7%D9%87-%D9%BE%D9%86%D8%AC%D9%85-%D8%B1%D8%B3%DB%8C%D8%AF-%DA%86%D8%B1%D8%A7-%D8%A7%DB%8C%D9%86-%D8%AF%D9%88%D8%B1-%D9%85%D8%AA%D9%81%D8%A7%D9%88%D8%AA-%D8%A7%D8%B3%D8%AA";
        string safhe_jadid = await client.GetStringAsync(newsUrl);

        string title = Regex.Match(safhe_jadid, @"<title>(.*?)</title>", RegexOptions.IgnoreCase).Groups[1].Value;
        if (string.IsNullOrEmpty(title)) title = "404";

        string pooshe = "News_2";
        Directory.CreateDirectory(pooshe);
        await File.WriteAllTextAsync(Path.Combine(pooshe, "title.txt"), title);

        var imgMatches = Regex.Matches(safhe_jadid, @"<img[^>]+src=[""']([^""']+)[""']", RegexOptions.IgnoreCase);

        int imgCount = 0;
        foreach (Match imgMatch in imgMatches)
        {
            if (imgCount >= 5) break;
            string imgUrl = imgMatch.Groups[1].Value;
            if (!imgUrl.StartsWith("http")) imgUrl = newsUrl.TrimEnd('/') + imgUrl;
            byte[] imgData = await client.GetByteArrayAsync(imgUrl);
            await File.WriteAllBytesAsync(Path.Combine(pooshe, $"image_{imgCount + 1}.jpg"), imgData);
            imgCount++;
        }
    }
}
