using System.Diagnostics;
using System;
using System.Threading;

public static class ThreadFunctions
{
    private static object lockObj = new object();

    public static void ShowThreadInformation(String taskName)
    {
        String msg = null;
        Thread thread = Thread.CurrentThread;
        lock (lockObj)
        {
            msg = String.Format("{0} thread information\n", taskName) +
                String.Format("   Background: {0}\n", thread.IsBackground) +
                String.Format("   Thread Pool: {0}\n", thread.IsThreadPoolThread) +
                String.Format("   Thread ID: {0}\n", thread.ManagedThreadId);
        }

        UnityEngine.Debug.Log($"[ShowThreadInformation] {msg}");
    }
}