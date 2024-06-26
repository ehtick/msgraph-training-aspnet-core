// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace GraphTutorial.Models
{
    public class DailyViewModel
    {
        // Day the view is for
        public DateTime Day { get; private set; }
        // Events on this day
        public IEnumerable<CalendarViewEvent> Events { get; private set; }

        public DailyViewModel(DateTime day, IEnumerable<CalendarViewEvent> events)
        {
            Day = day;
            Events = events;
        }
    }
}
