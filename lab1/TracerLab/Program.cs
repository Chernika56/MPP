﻿using TracerLab;
using TracingTools.Serializer;
using TracingTools.Tracing;

var tracer = new Tracer();

var firstThread = new Thread(() =>
{
    tracer.StartTrace();
    var thread = new Thread(() =>
    {
        var _outerClass = new OuterClass(tracer);
        _outerClass.MyMethod();
    });
    thread.Start();
    thread.Join();
    tracer.StopTrace();
});
firstThread.Start();
firstThread.Join();

var res = tracer.GetTraceResult();

var serializer = new SerializerJson();
var writer = new SerializedWriter(serializer);

using var stream = new StreamWriter("res.json");
writer.Write(res, stream);
writer.Write(res, Console.Out);
