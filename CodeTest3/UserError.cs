using System;
using System.Collections.Generic;
using System.Text;

namespace CodeTest3
{
    public abstract class UserError
    {
        public abstract string UEMessage();

    }
    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
    class BooleanInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a boolean only field. This fired an error!";
        }
    }
    class IntInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a integer only field. This fired an error!";
        }
    }
    class CharInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a integer input in a character only field. This fired an error!";
        }
    }
}
