using Microsoft.AspNetCore.SignalR;

namespace Whiteboard.Hubs;

public class BoardHub : Hub
{
    public async Task DrawingAsync(int startX, int startY, int endX, int endY)
    {
        // Broadcasts the coordinates to all clients except the sender
        await Clients.Others.SendAsync("OnDrawingAsync", startX, startY, endX, endY);
    }
}
