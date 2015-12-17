﻿namespace formulate.app.Forms.Fields
{
    public class TextField : IFormFieldType
    {
        public string Directive
        {
            get
            {
                return "formulate-text-field";
            }
        }
        public string TypeLabel
        {
            get
            {
                return "Text";
            }
        }
        public string Icon
        {
            get
            {
                return "icon-document-dashed-line";
            }
        }
    }
}