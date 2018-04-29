﻿namespace OnlyT.Services.Timer
{
    using System;
    using EventArgs;
    using Models;

    public interface ITalkTimerService
    {
        event EventHandler<TimerChangedEventArgs> TimerChangedEvent;

        void Start(int targetSecs, int talkId);

        void Stop();

        int CurrentSecondsElapsed { get; set; }

        bool IsRunning { get; }

        ClockRequestInfo GetClockRequestInfo();

        TimerStatus GetStatus();

        void SetupTalk(int talkId, int targetSeconds);
    }
}
