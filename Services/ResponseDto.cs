using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microservices.Shared.Dtos
{
	public class ResponseDto<T>
	{
		public T Data { get; set; }

		public int StatusCode { get; set; }

        [JsonIgnore]
        public bool IsSuccesfull { get; set; }

		public List<string> Errors { get; set; }


		public static ResponseDto<T> Success(T data,int statusCode)
		{
			return new ResponseDto<T>
			{
				Data = data,
				StatusCode = statusCode,
				IsSuccesfull = true
			};
		}

        public static ResponseDto<T> Success(int statusCode)
        {
            return new ResponseDto<T>
            {
                Data = default(T),
                StatusCode = statusCode,
                IsSuccesfull = true
            };
        }

		public static ResponseDto<T> Error(List<string> errors,int statusCode)
		{
			return new ResponseDto<T>({
				Errors = errors,
				StatusCode = statusCode,
				IsSuccesfull = false,
			};

		}
		public static ResponseDto<T>Error(string error,int statusCode)
		{
			return new ResponseDto<T>
			{
				Errors=new List<string>()
				{
					error
				},
				StatusCode=statusCode,
				IsSuccesfull=false
			};
		}

    }

}

