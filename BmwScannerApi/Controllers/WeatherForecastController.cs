using BmwScannerApi.Models;
using BmwScannerApi.Services;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;
using Microsoft.ML;
using Serilog;
using Tensorflow.Keras.Engine;

namespace BmwScannerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly MLModel _service;
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            //_service = new MLModel(engine);
        }

        [Route("predict")]
        [HttpPost]
        public async Task<List<Wheel>> Predict([FromBody] Content content)
        {
            Log.Logger = new LoggerConfiguration()
            .WriteTo.File(@"C:\temp\log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

            List<Wheel> wheelsImage = new List<Wheel>();

            try
            {
                string base64Str = (string)content.content;
                byte[] body = Convert.FromBase64String(base64Str);

                //using (StreamReader stream = new StreamReader(Request.Body))
                //{
                //    body = Helpers.ReadFully(stream.BaseStream);
                //}

                var input = new ModelInput()
                {
                    ImageSource = body,
                };
                var data = await WheelsImageService.GetData();

                var result = MLModel.PredictAllLabels(input);

                var existPrediction = result.Where(x => x.Value > 0.01).Any();

                if (existPrediction)
                {
                    foreach (var item in result.Where(x => x.Value > 0.01))
                    {
                        var existModel = wheelsImage.Where(x => x.WheelStyleName == item.Key).Any();

                        if (!existModel)
                        {
                            var wheel = data.Where(x => x.WheelStyleName == item.Key).FirstOrDefault();
                            wheelsImage.Add(wheel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Logger.Error(ex.Message, ex.InnerException);
            }

            return wheelsImage;
        }

        [Route("Specs")]
        [HttpPost]
        public async Task<List<WheelSpecs>> Specs([FromBody] string style)
        {
            // Obținerea datelor și filtrarea
            var data = await WheelsSpecsService.GetData();
            var filteredData = data.Where(x => x.WheelStyleName == style).ToList();

            return filteredData;
        }

        [Route("Images")]
        [HttpPost]
        public async Task<List<ThumbNailModel>> Images([FromBody] string style)
        {
            // Obținerea datelor și filtrarea
            var data = await WheelSpecsImagesService.GetData();
            var filteredData = data.Where(x => x.WheelStyleName == style).ToList();

            List<ThumbNailModel> Images = new List<ThumbNailModel>();

            foreach (var item in filteredData)
            {
                var thumbnail = new ThumbNailModel
                {
                    Name = item.Image
                };
                Images.Add(thumbnail);
            }

            return Images;
        }
    }
}
