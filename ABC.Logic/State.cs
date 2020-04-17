using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC.ENTITY;
namespace ABC.Logic
{
    public enum StateEnum
    {
        Fail,Success
    }
    public class State<T>
    {
        public StateEnum stateResult;
        public T data;

        public StateEnum StateResult { get => stateResult; set => stateResult = value; }
        public T Data { get => data; set => data = value; }
    }
}
