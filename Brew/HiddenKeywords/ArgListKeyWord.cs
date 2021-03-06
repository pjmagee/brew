using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace Brew.HiddenKeywords;

public class HiddenArgListKeyWord : IBrew
{
    private readonly ILogger<HiddenArgListKeyWord> logger;

    public HiddenArgListKeyWord(ILogger<HiddenArgListKeyWord> logger)
    {
        this.logger = logger;
    }

    public void Before()
    {
        Before(1, 2, 3);
        Before(y: 2, x: 1);
        Before(0, 0, null);
        Before(z: 1);
    }

    private void Before(int x = 0, int y = 0, int? z = null)
    {
        logger.LogInformation($"before: {x}, {y}, {z}");
    }

    public void After()
    {
        After(__arglist(1, "2", 3, true, new object(), DateTime.Now));
    }

    private void After(__arglist)
    {
        ArgIterator iterator = new ArgIterator(__arglist);

        List<object> items = new();

        while (iterator.GetRemainingCount() > 0)
        {
            var arg = iterator.GetNextArg();
            items.Add(TypedReference.ToObject(arg));
        }

        logger.LogInformation($"after: {string.Join(",", items)}");
    }
}
