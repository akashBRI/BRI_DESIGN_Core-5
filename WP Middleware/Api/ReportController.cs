using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using WP_Middleware.ViewModel;

namespace WP_Middleware.Api
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/api/Team")]
        public IActionResult Team()
        {
            var url = "https://app.insightful.io/api/v1/team";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";
            var result = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return Ok(result);

        }

        [Route("/api/Employees")]
        public IActionResult Employees()
        {
            var url = "https://app.workpuls.com/api/v1/employee";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";
            var result = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return Ok(result);

        }

        [Route("/api/Projects")]
        public IActionResult Projects()
        {
            var url = "https://app.workpuls.com/api/v1/project";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";
            var result = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return Ok(result);

        }

        [Route("/api/Tasks")]
        public IActionResult Tasks()
        {
            var url = "https://app.workpuls.com/api/v1/task";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";
            var result = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return Ok(result);

        }

        [Route("/api/GetEmployee")]
        public IActionResult GetEmployee(string id)
        {
            var result3 = "";
            var url2 = "https://app.workpuls.com/api/v1/employee/" + id;
            var httpRequest2 = (HttpWebRequest)WebRequest.Create(url2);
            httpRequest2.Accept = "application/json";
            httpRequest2.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";

            var httpResponse2 = (HttpWebResponse)httpRequest2.GetResponse();
            using (var streamReader = new StreamReader(httpResponse2.GetResponseStream()))
            {
                result3 = streamReader.ReadToEnd();
            }
            EmployeeViewModel employee = JsonConvert.DeserializeObject<EmployeeViewModel>(result3);

            return Ok(employee);
        }

        [Route("/api/GetTask")]
        public IActionResult GetTask(string id)
        {
            var url1 = "https://app.workpuls.com/api/v1/task/" + id;
            var httpRequest = (HttpWebRequest)WebRequest.Create(url1);
            httpRequest.Accept = "application/json";
            httpRequest.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";
            var result = "";
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return Ok(result);
        }

        [Route("/api/GetReport")]
        [HttpPost]
        public IActionResult GetReport(ReportGet reportGet)
        {
            var result2 = "";
            var url1 = "https://app.workpuls.com/api/v1/task";
            var httpRequest1 = (HttpWebRequest)WebRequest.Create(url1);
            httpRequest1.Accept = "application/json";
            httpRequest1.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";

            var httpResponse1 = (HttpWebResponse)httpRequest1.GetResponse();
            using (var streamReader = new StreamReader(httpResponse1.GetResponseStream()))
            {
                result2 = streamReader.ReadToEnd();
            }
            var jsonResult = JsonConvert.DeserializeObject(result2).ToString();
            List<TaskDetails> tasks = JsonConvert.DeserializeObject<List<TaskDetails>>(jsonResult);

            List<EmployeeViewModel> employee = new();
            EmployeeViewModel employ = new();

            if (reportGet.Employee == null)
            {
                var result3 = "";
                var url2 = "https://app.workpuls.com/api/v1/employee";
                var httpRequest2 = (HttpWebRequest)WebRequest.Create(url2);
                httpRequest2.Accept = "application/json";
                httpRequest2.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";

                var httpResponse2 = (HttpWebResponse)httpRequest2.GetResponse();
                using (var streamReader = new StreamReader(httpResponse2.GetResponseStream()))
                {
                    result3 = streamReader.ReadToEnd();
                }
                employee = JsonConvert.DeserializeObject<List<EmployeeViewModel>>(result3);
            } else
            {
                var result4 = "";
                var url4 = "https://app.workpuls.com/api/v1/employee" + reportGet.Employee;
                var httpRequest4 = (HttpWebRequest)WebRequest.Create(url4);
                httpRequest4.Accept = "application/json";
                httpRequest4.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";

                var httpResponse4 = (HttpWebResponse)httpRequest4.GetResponse();
                using (var streamReader = new StreamReader(httpResponse4.GetResponseStream()))
                {
                    result4 = streamReader.ReadToEnd();
                }
                employ = JsonConvert.DeserializeObject<EmployeeViewModel>(result4);

                employee.Add(employ);
            }

            try
            {
                ReportViewModel report = new();
                var datesplt = reportGet.Date;
                string[] words = datesplt.Split('-');
                string dateFrom = words[0].TrimStart();
                string dateTo = words[1].TrimStart();

            /*  DateTime fDate = Convert.ToDateTime(dateFrom);
                DateTime TDate = Convert.ToDateTime(dateTo);
                DateTime fd = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(fDate, TimeZoneInfo.Local.Id, "India Standard Time");
                DateTime td = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(TDate, TimeZoneInfo.Local.Id, "India Standard Time");
                long longFdateTime = new DateTimeOffset(fd).ToUnixTimeMilliseconds();
                long longTdateTime = new DateTimeOffset(td).ToUnixTimeMilliseconds();
                long tdate = longTdateTime + 84924000;*/
                
                string teamId = reportGet.Team;
                long tdate = reportGet.Tdate + 19800000;
                long fdate = reportGet.Fdate + 19800000;
;
                string projectId = reportGet.Project;
                string employeeId = reportGet.Employee;
                string taskId = reportGet.Task;

                string timeZone = TimeZoneInfo.Local.Id;
                DateTime dateNow = DateTime.Now;

                report.Fdate = dateFrom;
                report.Tdate = dateTo;
                report.ClockIn = fdate;
                report.ClockOut = tdate;
                report.TimeZone = timeZone;
                report.DateNow = dateNow;

                Resport resport = new Resport();
                List<ReportViewModel> reportViews = new List<ReportViewModel>();

                var url = "https://app.workpuls.com/api/v1/analytics/window?start=" + fdate + "&end=" + tdate + "&employeeId=" + employeeId + "&projectId=" + projectId + "&taskId=" + taskId + "&teamId=" + teamId;
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Accept = "application/json";
                httpRequest.Headers["Authorization"] = "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IndsZ2ZraW14cTRnYjRiayIsImFjY291bnRJZCI6InducHNucGh4anh3dzV1dCIsIm9yZ2FuaXphdGlvbklkIjoid29mMnFhXzF3Y3hvNjZhIiwidHlwZSI6InVzZXIiLCJ1c2VyVHlwZSI6ImFwaSIsImlhdCI6MTY0NDkxMzQxMywiZXhwIjozMTcxODkzNTU4MTMsImF1ZCI6WyJQUk9EIl0sImlzcyI6IlBST0QifQ.B-M7rL4Ou7AFMeRiYgwrXBKhFw8m6y5fR_U6xbux99E";
                var result1 = "";
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result1 = streamReader.ReadToEnd();
                }

                List<EmployeeDate> getData = JsonConvert.DeserializeObject<List<EmployeeDate>>(result1);
                int count = 0;
                List<EmployeeDate> exits = new();
                List<EmployeeDate> add = new();

                foreach (var item in getData)
                {
                    ReportViewModel reportView = new();
                    EmployeeViewModel emp = new();
                    try
                    {

                        TaskDetails taskdet = new();
                        foreach (var ts in tasks)
                        {
                            if(ts.id == item.taskId)
                            {
                                taskdet = ts;
                            }
                        }

                        
                        foreach (var ep in employee)
                        {
                            if (ep.id == item.employeeId)
                            {
                                emp = ep;
                            } 
                        }

                        string dead;
                        if(taskdet.deadline == null)
                        {
                            dead = "0";
                        } else
                        {
                            dead = taskdet.deadline;
                        }

                        reportView.ClockIn = item.start;
                        reportView.ClockOut = item.end;
                        reportView.TotalTime = item.duration;
                        reportView.PayRate = item.payRate;
                        reportView.TaskCreated = long.Parse(taskdet.createdAt);
                        reportView.TaskName = taskdet.name;
                        reportView.DueDate = long.Parse(dead);
                        reportView.AssignedTo = emp.name;
                        reportView.TimezoneOffset = item.timezoneOffset;
                        count++;
                        reportView.Count = count;
                        reportViews.Add(reportView);
                        add.Add(item);
                    }
                    catch (Exception ex)
                    {
                        reportView.ClockIn = item.start;
                        reportView.ClockOut = item.end;
                        reportView.TotalTime = item.duration;
                        reportView.PayRate = item.payRate;
                        reportView.TaskCreated = 0;
                        reportView.TaskName = "<div class='ui red horizontal label'>Task doesn't exist</div>";
                        reportView.DueDate = 0;
                        reportView.AssignedTo = emp.name;
                        reportView.TimezoneOffset = item.timezoneOffset;
                        count++;
                        reportView.Count = count;
                        reportViews.Add(reportView);
                        exits.Add(item);
                        Console.WriteLine(ex);
                    }
                }
                report.Exit = exits;
                report.ReportView = reportViews;
                return Ok(report);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                return Ok(ex);
            }

            

        }
    }
}
