using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace TestDecripts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtener llaves
            // llave publica ----Guardar en db llave privada. llave publica
            //post , Texto plano, llave publica -- busqueda llave publica --guardar texto cryp --

            //var keys =Encrypt.GenerateKey();
            // Console.WriteLine(JsonConvert.SerializeObject(keys.ToList()) + "Keys");
            var cryp = Encrypt.EncryptRSA("x4zEU9yKqtmdBV1X9zwIW8lwhbjjfpqf9vU/6g7T9nrYxRfVwdJEofzXnRpfCB6s/3InvcMYUOEco91SjjzOVSHvUjExVszLnYoXP5h+V/JqHImqWfA+p6ywlvxQxzhiqC7EBQ9rOB7EF/DsRYQZgQJSIHnlTiZBEk//X080O/F6UhrPfZCYD7oNf8VNFzXdaeuSfi2XohTVPBz8UdXO0sQm3RMNE5OukjAYf7GEdasO7wqAtzMIuPPQSIF1WHxt8sRpKpkqLe5hc83qfdIlWpV9E2grFPNAVaQWnVo3wIzVGKW3oKYmYTsMXIwIwLSmuS1ADQlgAxTgYxwHcTw/lT57IJXX/WDauLb4dpyI5ktbpPf599pojXyeb4GDRZBq8paUcMQj9EUrDEtst/DOPM8FMZl2vCv4HrFSgvzxywgh6hHH/pTsJE1AY07fNqNEexbJ58v+zpfDdaRjIH1GpflG/1SmcfhZeeAkgYPO3S9+0CWP0BRIpHw7ru03JQDcn7CI9Q/0mgOP71gQ31T4irbkRECSBBWYOfTMdlsGXv0GH668bd1AKsQXlfhe7hQolego8bKQ61jXgRsUmGXDuSPG7+1ms0E8tHRUmiPQ5CFOLk3X7TNCuFXnSLvZ49kfgySgz0li5IHHfZVFLgm+ltTIKj7HcwTheBX6oBihpYoM9VPpRmTamjPMyAx9wE/N7oCYc/CkVk1XvApGbsNUM+2+MC3fNinxZRca+r19e0i/37csVOWIiXt/iYg0PKbS",
                "{\"rol\":\"alcaldia\",\"departamento\":\"bogota\",\"municipio\":\"bogota\"}");

            //Console.WriteLine(cryp + "Dato Cryps :: Probando RSA en Base64");

            var de = Encrypt.Decrypt("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",
                cryp);
                //"anBQcEVNd3ZRTEllT0lSbVNTdTI0VWFDbDFza2l0RFZlcGNpOXN6SEdMc3F0RE4zZ1dXTWMzVU0yRFNXUUh5QVZ1TkFRNVI3VW9aZGFiL3g5d3VtVGdyQk9ESG9EZkxWaDF4MmNCd2kxdDRMMm9KelpKNTZ5K3VkbGlHRDBudWFBR0d6djhYdjJ6NlV0ZFJhaDZzc0lPVGNLMmVPc1JRa0pKUFJjSGRuNFV4TTVOdlJabUh0SHRZYWhyS3NIYWdRWjQrV0NxbFZTSEErRXA2RS91b0NLSEg4TVpVNHFXVEhoOXNmTnQ5ZVhWQlZFS01YY3o1QlR2YlYxenhSaytNOTlvS3JOaHNGOUtxcXBHK1k3VXJMaHVTOUQ0cTd5bmU1ZjR0L000cDZOK1BGSU1OSWJ2cDlwMWV1bTdONGMrTzFXNlJ5YWdkRVJobW1xTzhwZW5hWStRPT0=");


            //var keys2 = Encrypt.GenerateKey();

            //if(keys.FirstOrDefault(f => f.Key == "42f46a59-6875-4904-96fb-1ff6ca469312").Value == keys2.FirstOrDefault(f => f.Key == "42f46a59-6875-4904-96fb-1ff6ca469312").Value)
            //{
            //    Console.WriteLine(de + "Dato DeCryps");
            //}

            //Console.WriteLine(de + "Dato DeCryps");
        }
    }
}
