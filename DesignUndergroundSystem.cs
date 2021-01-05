using System;
using System.Collections.Generic;
using System.Text;

/**
 * Space Complexity:O(N)
 * Main Class: 
 * Constructor:
 *      checkIns - dictionary that keeps track of userId, checkInStation and checkInTime
 *      journeys - dictionary that keeps track of total time and numberOfTrips from checkinStation - checkoutStation
 * Checkin: id, station, time
 *      Everytime there's a checkin, add to checkIns dictionary
 *      Time Complexity: O(1)
 * Checkout: id, station, time
 *      When there's a checkout, find that customer's checkin time and checkin station
 *      Create key formatted in checkinStation - checkoutStation and add/update journeys dicitionary
 *      Calculate new averageTime
 *      Delete from checkIns dictionary the info of user who just checked out
 *      Time Complexity: O(1)
 * GetAverageTime: checkinStation, checkoutStation
 *      Return average time from checkinStation - checkoutStation
 *      Time Complexity:O(1)
 *      
 * CheckIn Class:
 *  Constructor: StationName and Time
 * 
 * Journey Class:
 *  Constructor: TotalTime, NumOfTrips, AverageTime
 *
 */

namespace Algos_C_Sharp
{
    class DesignUndergroundSystem
    {
        public class UndergroundSystem
        {

            public Dictionary<int, CheckIn> CheckIns = new Dictionary<int, CheckIn>();
            public Dictionary<string, Journey> Journeys = new Dictionary<string, Journey>();

            public UndergroundSystem() { }

            public void CheckIn(int id, string stationName, int t)
            {
                var checkIn = new CheckIn(stationName, t);
                CheckIns.Add(id, checkIn);
            }

            public void CheckOut(int id, string stationName, int t)
            {
                var checkIn = CheckIns[id];
                int timeDiff = t - checkIn.Time;
                string key = $"{checkIn.StationName} - {stationName}";
                if (Journeys.ContainsKey(key))
                {
                    var journey = Journeys[key];
                    int updatedTotalTime = journey.TotalTime + timeDiff;
                    int updatedNumOfTrips = journey.NumOfTrips + 1;
                    double updatedAverageTime = (double)updatedTotalTime / updatedNumOfTrips;
                    journey.TotalTime = updatedTotalTime;
                    journey.NumOfTrips = updatedNumOfTrips;
                    journey.AverageTime = updatedAverageTime;
                }
                else
                {
                    var newJourney = new Journey(timeDiff, 1, timeDiff);
                    Journeys.Add(key, newJourney);
                }
                CheckIns.Remove(id);
            }

            public double GetAverageTime(string startStation, string endStation)
            {
                string key = $"{startStation} - {endStation}";
                return Journeys[key].AverageTime;
            }
        }

        public class CheckIn
        {
            public string StationName { get; }
            public int Time { get; }
            public CheckIn(string stationName, int time)
            {
                StationName = stationName;
                Time = time;
            }
        }

        public class Journey
        {
            public int TotalTime { get; set; }
            public int NumOfTrips { get; set; }
            public double AverageTime { get; set; }

            public Journey(int totalTime, int numOfTrips, double averageTime)
            {
                TotalTime = totalTime;
                NumOfTrips = numOfTrips;
                AverageTime = averageTime;
            }
        }
    }
}
