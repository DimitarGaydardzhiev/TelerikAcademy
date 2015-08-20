namespace StringBuilder.Extensions
{
    using System;
    using System.Text;
    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            StringBuilder newBuilder = new StringBuilder();
            newBuilder.Append(builder.ToString().Substring(index, length));
            return newBuilder;
        }
    }
}
