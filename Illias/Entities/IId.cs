﻿/*
 * Copyright (c) 2010-2016 Achim 'ahzf' Friedland <achim.friedland@graphdefined.com>
 * This file is part of Illias <http://www.github.com/Vanaheimr/Illias>
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

#endregion

namespace org.GraphDefined.Vanaheimr.Illias
{

    /// <summary>
    /// The common interface of a datastructure used as an unique identification.
    /// </summary>
    public interface IId : IComparable
    {

        //global::org.GraphDefined.WWCP.ChargingPool_Id Clone { get; }
        //int CompareTo(global::org.GraphDefined.WWCP.ChargingPool_Id EVP_Id);
        //bool Equals(global::org.GraphDefined.WWCP.ChargingPool_Id EVP_Id);
        //int GetHashCode();
        //ulong Length { get; }
        //string ToString();

    }

    /// <summary>
    /// The common interface of a datastructure used as an unique identification.
    /// </summary>
    public interface IId<T> : IComparable<T>,
                              IComparable
    {

        /// <summary>
        /// The unique identification of the data structure.
        /// </summary>
        T Id { get; }

    }

}
