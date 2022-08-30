using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server.MessagePack
{
    internal class Client
    {
        public TcpClient desktopClient;

        public TcpClient inputClient;

        public object Server;

        public long uhid;

        public IntPtr hWnd;

        public ManualResetEvent minEvent;

        public byte[] pixels;

        public int pixelsWidth;

        public int pixelsHeight;

        public int screenWidth;

        public int screenHeight;

        public Image Bitmap;

        public bool fullScreen;

        public int wndLeft;

        public int wndTop;

        public int wndRight;

        public int wndBottom;
    }
}
