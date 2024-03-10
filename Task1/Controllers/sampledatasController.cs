using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Task1.contracts;
using Task1.Data;
using Task1.dtos.Sampledatadtos;

namespace Task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class sampledatasController : ControllerBase
    {
        private readonly ISampleDataRepo _sampledatarepo;
        private readonly Task1DbContext _context;
        private readonly IMapper _mapper;

        public sampledatasController(Task1DbContext context,IMapper mapper,ISampleDataRepo sampledatarepo)
        {
            this._context = context;
            this._mapper = mapper;
            this._sampledatarepo = sampledatarepo;
        }

        // GET: api/sampledatas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SampleDataDtoGet>>> GetSampleData()
        {
            // var t= await _context.SampleData.ToListAsync();
           var t = await _sampledatarepo.GetAllAsync();
            var ans=_mapper.Map<List<SampleDataDtoGet>>(t);
            return ans;
        }

        // GET: api/sampledatas/5
        [HttpGet("{bu_code}")]
        public async Task<ActionResult<List<sampledata>>> Getsampledata(string bu_code)
        {
           // var sampledata = await _context.SampleData.Where(p => p.BU_CODES == bu_code).FirstOrDefaultAsync();
            var sampledata=await _sampledatarepo.GetDetails(bu_code);

            if (sampledata == null)
            {
                return NotFound();
            }

            return sampledata;
        }
        /* [HttpGet("{id}")]
         public async Task<ActionResult<sampledata>> GetsampledataUsing_id(int id)
         {
             var sampledata = await _context.SampleData.FindAsync(id);

             if (sampledata == null)
             {
                 return NotFound();
             }

             return sampledata;
         }*/

        // PUT: api/sampledatas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> Putsampledata(int id, sampleDataPutDto sampledataput)
        {
            if (id != sampledataput.Id)
            {
                return BadRequest();
            }
            Boolean b = await _sampledatarepo.Exists(id);
            if (!b)
            {
                return BadRequest();
            }
            var a = await _sampledatarepo.GetAsyncid(id);
            _mapper.Map(sampledataput, a);
            //_context.Entry(ans).State = EntityState.Modified;
           

            try
            {
                await _sampledatarepo.UpdateAsync(a);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await sampledataExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/sampledatas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SampleDataPostDto>> Postsampledata(SampleDataPostDto sampledatapost)
        {
            var data = _mapper.Map<sampledata>(sampledatapost);
           await _sampledatarepo.AddAsync(data);
           /* _context.SampleData.Add(sampledata);
            await _context.SaveChangesAsync();*/

            return CreatedAtAction("Getsampledata", new { id = data.Id }, data);
        }

        // DELETE: api/sampledatas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletesampledata(int id)
        {
            var sampledata = await _context.SampleData.FindAsync(id);
            if (sampledata == null)
            {
                return NotFound();
            }

            _context.SampleData.Remove(sampledata);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        //using bucodes delete the record 
        [HttpDelete("Bu_codes/{bu_codes}")]
        [Authorize(Roles = "Administraton")]
        public async Task<IActionResult> Deletesampledatausing_bucodes(string bu_codes)
        {
            //var sampledata = await _context.SampleData.FindAsync(bu_codes);
            var sampledata=await _sampledatarepo.GetAsync(bu_codes);
            if (sampledata == null)
            {
                return NotFound();
            }

            //_context.SampleData.Remove(sampledata);
            //await _context.SaveChangesAsync();
            await _sampledatarepo.DeleteAsync(bu_codes);

            return NoContent();
        }

        // GET: api/sampledatas/city/weather
        [HttpGet("weather/{bu_codes}")]
        public async Task<ActionResult<string>> GetWeatherData(string bu_codes)
        {
            // var city = await _context.SampleData.Include(p=>p.state).Select(p=>p.).FirstOrDefaultAsync(p => p.BU_CODES == bu_code);
            // string ci = await _context.stateTables.Where(p=>p.ID==IDa)Select(p => p.CITY).;
            // Replace 'YOUR_API_KEY' with your actual API key
            string apiKey = "7b4aea481c3fc848ed2ba151499387d1";
            var s = await _context.SampleData.Select(q => new { Bu_codes = q.BU_CODES, City = q.state.CITY }).ToListAsync();
            string si = null;
            
            foreach (var r in s)
            {
                if (r.Bu_codes == bu_codes)
                {
                    si = r.City;
                    break;
                }
            }
            // Construct the URL for the weather API
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={si}&appid={apiKey}";
            // Initialize HttpClient
            using (HttpClient client = new HttpClient())
            {
                // Make a GET request to the weather API
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content
                    string weatherData = await response.Content.ReadAsStringAsync();
                    // You may want to parse and manipulate the weatherData as needed
                    return Content(weatherData,"application/json");
                }
                else
                {
                    // If the API request fails, return a problem response
                    return Problem($"Failed to retrieve weather data. Status code: {response.StatusCode}");
                }
            }

        }


        [HttpGet("weather_using_city/{city}")]
        public async Task<ActionResult<string>> GetWeatherDatausingcity(string city)
        {
            // var city = await _context.SampleData.Include(p=>p.state).Select(p=>p.).FirstOrDefaultAsync(p => p.BU_CODES == bu_code);
            // string ci = await _context.stateTables.Where(p=>p.ID==IDa)Select(p => p.CITY).;
            // Replace 'YOUR_API_KEY' with your actual API key
            string apiKey = "7b4aea481c3fc848ed2ba151499387d1";
           /* var s = await _context.SampleData.Select(q => new { Bu_codes = q.BU_CODES, City = q.state.CITY }).ToListAsync();
            string si = null;

            foreach (var r in s)
            {
                if (r.Bu_codes == bu_codes)
                {
                    si = r.City;
                }
            }*/
            // Construct the URL for the weather API
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";
            // Initialize HttpClient
            using (HttpClient client = new HttpClient())
            {
                // Make a GET request to the weather API
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    // Read the response content
                    string  weatherData = await response.Content.ReadAsStringAsync();
                   // object WeatherObject = JsonConvert.DeserializeObject<object>(weatherData);
                    // You may want to parse and manipulate the weatherData as needed
                    return Content(weatherData,"application/json");
                }
                else
                {
                    // If the API request fails, return a problem response
                    return Problem($"Failed to retrieve weather data. Status code: {response.StatusCode}");
                }
            }
        }

        private async Task<bool> sampledataExists(int id)
        {
            return await _sampledatarepo.Exists(id);
        }
    }
}
