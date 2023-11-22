using Newtonsoft.Json;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;

namespace SimpleTrader.FinancialModelingPrepAPI.Services;

public class MajorIndexService : IMajorIndexService
{
    public async Task<MajorIndex> GetMajorIndex(MajorIndexType indexType)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync("https://financialmodelingprep.com//api/v3/majors-indexes/.DJI&apikey=6mPcapUtNG1P9Vteo7unXwNfDRroyr9Z");
            string jsonResponse = await response.Content.ReadAsStringAsync();
            
            MajorIndex? majorIndex = JsonConvert.DeserializeObject<MajorIndex>(jsonResponse);
            return majorIndex;
        }
    }
}