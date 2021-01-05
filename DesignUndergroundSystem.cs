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

    }
}
