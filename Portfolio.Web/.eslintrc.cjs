module.exports = {
  root: true,
  env: {
    node: true,
  },
  extends: [
    "plugin:vue/essential",
    "eslint:recommended",
    "@vue/eslint-config-typescript/recommended",
    "@vue/eslint-config-prettier",
  ],
  parserOptions: {
    ecmaVersion: "latest",
  },
  rules: {
    "prettier/prettier": [
      "error",
      {
        endOfLine: "auto",
      },
    ],
    "vue/valid-v-slot": "off",
    "@typescript-eslint/no-explicit-any": "off",
    "@typescript-eslint/no-non-null-assertion": "off",
    "@typescript-eslint/explicit-module-boundary-types": "off",
    "vue/no-v-text-v-html-on-component": "off",
    "no-debugger": process.env.NODE_ENV === "production" ? "warn" : "off",
    "no-console": process.env.NODE_ENV === "production" ? "error" : "warn",
    "vue/multi-word-component-names": 0,
  },
  ignorePatterns: ["/**/*.g.ts"],
};
