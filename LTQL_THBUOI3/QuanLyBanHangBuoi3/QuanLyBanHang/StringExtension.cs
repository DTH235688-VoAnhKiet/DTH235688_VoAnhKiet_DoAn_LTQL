using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyBanHang
{
    public static class StringExtensions
    {
        public static string GenerateSlug(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            text = text.ToLowerInvariant();

            // Bỏ dấu tiếng Việt
            text = RemoveDiacritics(text);

            // Chỉ giữ chữ, số, khoảng trắng
            text = Regex.Replace(text, @"[^a-z0-9\s]", "");

            // Gộp khoảng trắng
            text = Regex.Replace(text, @"\s+", " ").Trim();

            // Đổi khoảng trắng thành dấu -
            return text.Replace(" ", "-");
        }

        private static string RemoveDiacritics(string text)
        {
            var normalized = text.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (char c in normalized)
            {
                if (System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c)
                    != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(c);
                }
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}