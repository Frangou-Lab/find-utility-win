﻿#region License

// Copyright 2018 Frangou Lab
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

#endregion

using System;
using System.Collections.Generic;

namespace FrangouLab.Geneutils.Extensions
{
    public static class DictionaryExtensions
    {
        public static TValue GetOrSet<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TKey, TValue> factory)           
        {
            if (dictionary.ContainsKey(key))
                return dictionary[key];

            var value = factory(key);
            dictionary.Add(key, value);

            return dictionary[key];
        }
    }
}
