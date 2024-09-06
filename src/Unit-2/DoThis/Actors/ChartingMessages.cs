using Akka.Actor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChartApp.Actors
{
    public class GatherMetrics { }

    public class Metric
    {
        public string Series { get; private set; }
        public float CounterValue { get; private set; }
        public Metric(string series, float counterValue)
        {
            Series = series;
            CounterValue = counterValue;
        }
    }

    public enum CounterType
    {
        Cpu,
        Memory,
        Disk
    }

    public class SubscribeCounter
    {
        public IActorRef Subscriber { get; private set; }
        public CounterType Counter {  get; private set; }

        public SubscribeCounter(CounterType counter, IActorRef subscriber)
        {
            Subscriber = subscriber;
            Counter = counter;
        }
    }

    public class UnsubscribeCount
    {
        public IActorRef Subscriber { get; set; }
        public CounterType Counter { get; private set; }


        public UnsubscribeCount(CounterType counterType, IActorRef subscriber)
        {
            Subscriber = subscriber;
            Counter = counterType;
        }
    }
}
