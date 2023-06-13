/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./**/*.{razor,html}"],
  theme: {
    extend: {
      fontFamily: {
        "logo": "Dancing Script",
        "body": "Noto Sans"
      }
    },
  },
  plugins: [],
}

