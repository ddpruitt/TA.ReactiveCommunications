﻿// This file is part of the TA.Ascom.ReactiveCommunications project
// 
// Copyright © 2018 Tigra Astronomy, all rights reserved.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
// documentation files (the "Software"), to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so. The Software comes with no warranty of any kind.
// You make use of the Software entirely at your own risk and assume all liability arising from your use thereof.
// 
// File: successful_transaction.cs  Last modified: 2018-08-27@22:37 by Tim Long

using System.Linq;
using JetBrains.Annotations;
using Machine.Specifications;

namespace TA.Ascom.ReactiveCommunications.Specifications.Behaviours
    {
    [Behaviors]
    [UsedImplicitly]
    internal class successful_transaction : rxascom_behaviour
        {
        It should_not_indicate_failed = () => Transaction.Failed.ShouldBeFalse();
        It should_indicate_success = () => Transaction.Successful.ShouldBeTrue();
        It should_indicate_completed = () => Transaction.Completed.ShouldBeTrue();
        It should_have_correct_lifecycle_state = () => Transaction.State.ShouldEqual(TransactionLifecycle.Completed);
        It should_not_have_an_error_message = () => Transaction.ErrorMessage.Any().ShouldBeFalse();
        }
    }