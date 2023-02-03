﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqsConsumer
{
    public class CustomerCreated
    {
        public required Guid Id { get; set; }

        public required string FullName { get; set; }

        public required string Email { get; set; }

        public required string GitHubUsername { get; set; }

        public required DateTime DateOfBirth { get; set; }
    }
}
