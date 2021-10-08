using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace SignalRChat.Hubs
{
    public class MarkisHub : Hub
    {
        private static IList<string> users = new List<string>();
        public static System.Threading.SemaphoreSlim semaphore = new System.Threading.SemaphoreSlim(1, 1);

        public async Task ShowContractGeometry(string sid, string contractString)
        {
            using (var cancellationTokenSource = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(20)))
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var browserConnected = await CheckIfBrowserConnectedAsync(sid);
                    if (browserConnected)
                    {
                        try
                        {
                            await Clients.Groups(sid).SendAsync("Map.ShowContract", sid, contractString);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error invoking ShowContractGeometry: {0}", ex.Message);
                        }
                        
                        cancellationTokenSource.Cancel();
                        cancellationTokenSource.Dispose();
                        break;
                    }
                    else
                    {
                        var cancelled = cancellationTokenSource.Token.WaitHandle.WaitOne(1000);

                        if (cancelled)
                        {
                            cancellationTokenSource.Cancel();
                            cancellationTokenSource.Dispose();
                            break;
                        }
                    }

                    

                }
            }

        }

        public async Task CreateContractGeometry(string sid, string contractString)
        {
            using (var cancellationTokenSource = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(20)))
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var browserConnected = await CheckIfBrowserConnectedAsync(sid);
                    if (browserConnected)
                    {
                        try
                        {
                            await Clients.Groups(sid).SendAsync("Map.CreateContract", sid, contractString);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error invoking CreateContractGeometry: {0}", ex.Message);
                        }
                        
                        cancellationTokenSource.Cancel();
                        cancellationTokenSource.Dispose();
                        break;
                    }
                    else
                    {
                        var cancelled = cancellationTokenSource.Token.WaitHandle.WaitOne(1000);

                        if (cancelled)
                        {
                            cancellationTokenSource.Cancel();
                            cancellationTokenSource.Dispose();
                            break;
                        }
                    }

                }
            }
        }

        public async Task ShowEstateGeometry(string sid, string contractString)
        {
            using (var cancellationTokenSource = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(20)))
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var browserConnected = await CheckIfBrowserConnectedAsync(sid);
                    if (browserConnected)
                    {
                        try
                        {
                            await Clients.Groups(sid).SendAsync("Map.ShowEstateGeometry", sid, contractString);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error invoking ShowEstateGeometry: {0}", ex.Message);
                        }
                        
                        cancellationTokenSource.Cancel();
                        cancellationTokenSource.Dispose();
                        break;
                    }
                    else
                    {
                        var cancelled = cancellationTokenSource.Token.WaitHandle.WaitOne(1000);

                        if (cancelled)
                        {
                            cancellationTokenSource.Cancel();
                            cancellationTokenSource.Dispose();
                            break;
                        }
                    }

                }
            }
            
        }

        public async Task ShowLongLeaseGeometry(string sid, string contractString)
        {
            using (var cancellationTokenSource = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(20)))
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var browserConnected = await CheckIfBrowserConnectedAsync(sid);
                    if (browserConnected)
                    {
                        try
                        {
                            await Clients.Groups(sid).SendAsync("Map.ShowLongLeaseGeometry", sid, contractString);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error invoking ShowLongLeaseGeometry: {0}", ex.Message);
                        }
                        
                        cancellationTokenSource.Cancel();
                        cancellationTokenSource.Dispose();
                        break;
                    }
                    else
                    {
                        var cancelled = cancellationTokenSource.Token.WaitHandle.WaitOne(1000);

                        if (cancelled)
                        {
                            cancellationTokenSource.Cancel();
                            cancellationTokenSource.Dispose();
                            break;
                        }
                    }

                }
            }
        }

        public async Task CreatePurchaseGeometry(string sid, string contractString)
        {
            using (var cancellationTokenSource = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(20)))
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var browserConnected = await CheckIfBrowserConnectedAsync(sid);
                    if (browserConnected)
                    {
                        try
                        {
                            await Clients.Groups(sid).SendAsync("Map.CreatePurchaseGeometry", sid, contractString);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error invoking CreatePurchaseGeometry: {0}", ex.Message);
                        }
                        
                        cancellationTokenSource.Cancel();
                        cancellationTokenSource.Dispose();
                        break;
                    }
                    else
                    {
                        var cancelled = cancellationTokenSource.Token.WaitHandle.WaitOne(1000);

                        if (cancelled)
                        {
                            cancellationTokenSource.Cancel();
                            cancellationTokenSource.Dispose();
                            break;
                        }
                    }

                }
            }
        }

        public async Task CreateSaleGeometry(string sid, string contractString)
        {
            using (var cancellationTokenSource = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(20)))
            {
                while (!cancellationTokenSource.Token.IsCancellationRequested)
                {
                    var browserConnected = await CheckIfBrowserConnectedAsync(sid);
                    if (browserConnected)
                    {
                        try
                        {
                            await Clients.Groups(sid).SendAsync("Map.CreateSaleGeometry", sid, contractString);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error invoking CreateSaleGeometry: {0}", ex.Message);
                        }
                        
                        cancellationTokenSource.Cancel();
                        cancellationTokenSource.Dispose();
                        break;
                    }
                    else
                    {
                        var cancelled = cancellationTokenSource.Token.WaitHandle.WaitOne(1000);

                        if (cancelled)
                        {
                            cancellationTokenSource.Cancel();
                            cancellationTokenSource.Dispose();
                            break;
                        }
                    }

                }
            }
        }

        public async Task OperationCompleted(string sid, string message)
        {
            try
            {
                await Clients.Groups(sid).SendAsync("Desktop.OperationCompleted", sid, message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error invoking OperationCompleted: {0}", ex.Message);
            }
            

        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var context = Context.GetHttpContext();
            if (context != null)
            {
                var request = context.Request;
                if (request != null)
                {
                    var query = request.Query;
                    if (query != null && Context.ConnectionId != null)
                    {
                        var sid = query["sid"];

                        try
                        {
                            await semaphore.WaitAsync();
                            users.Remove(sid);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error removing sessionId from users: {0}", ex.Message);
                        }
                        finally
                        {
                            semaphore.Release();
                        }

                        await Groups.RemoveFromGroupAsync(Context.ConnectionId, sid);
                    }
                    
                }
                
            }

            await base.OnDisconnectedAsync(exception);
            
        }

        public override async Task OnConnectedAsync()
        {
            var context = Context.GetHttpContext();
            if (context != null)
            {
                var request = context.Request;
                if (request != null)
                {
                    var query = request.Query;
                    if (query != null && Context.ConnectionId != null)
                    {
                        var sid = query["sid"];
                        if (!String.IsNullOrEmpty(sid))
                        {
                            try
                            {
                                await semaphore.WaitAsync();
                                users.Add(sid);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error adding sessionId to users: {0}", ex.Message);
                            }
                            finally
                            {
                                semaphore.Release();
                            }
                            
                        }
                        await Groups.AddToGroupAsync(Context.ConnectionId, sid);
                    }
                    
                }
                
            }

            await base.OnConnectedAsync();
            
        }

        public async Task<bool> CheckIfBrowserConnectedAsync(string sid)
        {
            bool browserConnected = false;

            try
            {
                await semaphore.WaitAsync();
                if (users != null && users.Where(usr => usr != null ? usr.Equals(sid) : false).Count() > 1)
                {
                    browserConnected = true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error checking browser connected status: {0}", ex.Message);
            }
            finally
            {
                semaphore.Release();
            }

            return browserConnected;
        }

    }
}