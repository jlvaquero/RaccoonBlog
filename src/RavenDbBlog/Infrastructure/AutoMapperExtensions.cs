using System;
using System.Collections;
using System.Collections.Generic;
using AutoMapper;

namespace RavenDbBlog.Infrastructure
{
    public static class AutoMapperExtensions
    {
        public static List<TResult> MapTo<TResult>(this IEnumerable self)
        {
            return (List<TResult>) Mapper.Map(self, self.GetType(), typeof (List<TResult>));
        }

        public static TResult MapTo<TResult>(this object self)
        {
            return (TResult)Mapper.Map(self, self.GetType(), typeof(TResult));
        }
    }
}