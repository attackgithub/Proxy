﻿using System;

namespace NetCoreStack.Proxy.Test.Contracts
{
    public class SimpleModel
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Value { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
