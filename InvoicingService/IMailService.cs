﻿using EFCoreTutorialGit;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoicingService
{
    public interface IMailService
    {
        Mail GetMailByScheduleId(int id);
    }
}
