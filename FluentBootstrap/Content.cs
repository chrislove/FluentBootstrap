﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBootstrap
{
    public class Content : Component
    {
        private readonly string _content;

        public Content(BootstrapHelper helper, string content)
            : base(helper)
        {
            _content = content;
        }

        protected override void OnStart(TextWriter writer)
        {
            writer.Write(_content);
        }
    }
}
