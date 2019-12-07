﻿using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list of Video objects
                throw new Exception("Oops some low level Youtube error.");
            }
            catch (Exception ex)
            {
                // Log
                throw new YouTubeException("Could not fetch the videos from Youtube.", ex);
            }

            return new List<Video>();
        }

    }
}