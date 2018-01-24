﻿using System;

namespace YouTubeApi
{
    public class YouTubeVideo
    {
        public string id, title, description;
        public DateTime publishedDate;

        public YouTubeVideo(string id)
        {
            this.id = id;
            YouTubeAPI.GetVideoInfo(this);
        }

    }

}