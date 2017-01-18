﻿using EagleEye.GVizApi;
using EagleEye.Settings;
using log4net;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace EagleEye.EEPlatformApi
{
    public static class EagleEyePlatformApi
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(EagleEyePlatformApi));

        /// <summary>
        /// Send chart data table to EagleEye platform via a PUT request.
        /// </summary>
        /// <param name="chartId">The chart's _id property.</param>
        /// <param name="json">The data table json.</param>
        private static void PutDataTableToEagleEye(string chartId, string json)
        {
            // API: <https://github.com/CVBDL/EagleEye-Docs/blob/master/rest-api/rest-api.md#edit-data-table>

            log.Info("Sending data to EagleEye platform ...");
            log.Info("ChartId :: " + chartId);
            log.Info("JSON :: " + json);

            //EagleEyeSettings settings = EagleEyeSettingsReader.Settings;
            //HttpClient httpClient = new HttpClient();
            //StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            //string requestUri = settings.ApiRootEndpoint + "charts/" + chartId + "/datatable";
            //try
            //{
            //    HttpResponseMessage response = httpClient.PutAsync(requestUri, content).Result;
            //    response.EnsureSuccessStatusCode();

            //    // use for debugging
            //    HttpContent responseContent = response.Content;
            //    string responseBody = responseContent.ReadAsStringAsync().Result;
            //    log.Info(string.Format("HTTP response: {0}", responseBody));
            //}
            //catch (HttpRequestException e)
            //{
            //    log.Info("Error: Put data table to chart with id '" + chartId + "'");
            //    Console.WriteLine("Message :{0} ", e.Message);
            //}

            log.Info("Sending data to EagleEye platform ... Done.");
        }

        public static void EditDataTable(string chartId, DataTable dataTable)
        {
            if (string.IsNullOrWhiteSpace(chartId)) return;

            string json = dataTable.ToJSON();

            PutDataTableToEagleEye(chartId, json);
        }
    }
}
