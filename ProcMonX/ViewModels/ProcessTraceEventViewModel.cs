﻿using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
using ProcMonX.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcMonX.ViewModels {
    sealed class ProcessTraceEventViewModel : TraceEventDataViewModel {
        public readonly ProcessTraceData ProcessData;
        internal ProcessTraceEventViewModel(TraceEventDataViewModel evt) : base(evt.Data, evt.Type, evt.Details) {
            ProcessData = (ProcessTraceData)evt.Data;
            Debug.Assert(ProcessData != null);
        }

        public string CommandLine => ProcessData.CommandLine;
        public int Session => ProcessData.SessionID;
        public ulong Key => ProcessData.UniqueProcessKey;
        public string ImageFileName => ProcessData.ImageFileName;
        public int ParentID => ProcessData.ParentID;
        public string PackageFullName => ProcessData.PackageFullName;
        public int ExitCode => ProcessData.ExitStatus;
        public ProcessFlags Flags => ProcessData.Flags;
        public string AppId => ProcessData.ApplicationID;
    }
}
