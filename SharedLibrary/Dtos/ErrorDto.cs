﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        //Bircok hata icin liste dondum.
        public List<String> Errors { get; private set; }
        //Hatayi gosterip gostermeme
        public bool IsShow { get; private set; }
        public ErrorDto()
        {
            Errors = new List<String>();  
        }
        public ErrorDto(string error,bool isShow)
        {
            Errors.Add(error);
            isShow = true;
        }
        public ErrorDto(List<string> errors,bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }
    }
}
