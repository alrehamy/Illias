﻿/*
 * Copyright (c) 2010-2014 Achim 'ahzf' Friedland <achim@graphdefined.org>
 * This file is part of Illias Commons <http://www.github.com/Vanaheimr/Illias>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#region Usings

using System;
using System.Collections.Generic;

#endregion

namespace eu.Vanaheimr.Illias.Commons
{

    /// <summary>
    /// Provides a generic mutable map/dictionary.
    /// </summary>
    /// <typeparam name="TKey">The type of the keys.</typeparam>
    /// <typeparam name="TValue">The type of the values.</typeparam>
    public interface IMap<TKey, TValue> : IImmutableMap<TKey, TValue>
        where TKey : IEquatable<TKey>, IComparable<TKey>, IComparable
    {

        IMap<TKey, TValue>  Set(TKey Key, TValue Value);
        IMap<TKey, TValue>  Remove(TKey Key);

    }

}
