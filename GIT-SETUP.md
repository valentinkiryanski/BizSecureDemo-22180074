# Git setup – init, commit, push (without Visual Studio)

Do this from **Command Prompt**, **PowerShell**, or **Git Bash**. All commands are the same.

---

## 1. Go to the project folder (repo root)

The repo root is the folder that contains `BizSecureDemo22180074.sln` and `.gitignore`.

**PowerShell / CMD:**
```powershell
cd "c:\Users\valen\Downloads\BizSecureDemo22180074 (1)\BizSecureDemo22180074\BizSecureDemo22180074"
```

**Git Bash:**
```bash
cd "/c/Users/valen/Downloads/BizSecureDemo22180074 (1)/BizSecureDemo22180074/BizSecureDemo22180074"
```

---

## 2. Initialize the local repo

```bash
git init
```

You should see: `Initialized empty Git repository in ...`

---

## 3. Stage all files (respects .gitignore)

```bash
git add .
```

Only files **not** in `.gitignore` will be staged (no `bin/`, `obj/`, `.vs/`, `.env`, etc.).

---

## 4. Check what will be committed

```bash
git status
```

You should see:
- `.gitignore`, `BizSecureDemo22180074.sln`, `BizSecureDemo22180074\...` (source files)
- You must **not** see: `bin\`, `obj\`, `.vs\`, `.env`, or `secrets.json`

If you see those, the repo is in the wrong folder or `.gitignore` is missing. Fix that before committing.

---

## 5. First commit

```bash
git commit -m "Initial commit"
```

---

## 6. Create the repo on GitHub (once)

1. Open https://github.com/new
2. Sign in with your GitHub account
3. **Repository name:** e.g. `BizSecureDemo-22180074`
4. **Public** or **Private** – your choice
5. Do **not** check “Add a README” (you already have files locally)
6. Click **Create repository**

---

## 7. Connect your local repo to GitHub

GitHub will show something like:

```
…or push an existing repository from the command line
  git remote add origin https://github.com/YOUR_USERNAME/BizSecureDemo-22180074.git
  git branch -M main
  git push -u origin main
```

Run those three commands (replace the URL with your repo URL if different):

```bash
git remote add origin https://github.com/YOUR_USERNAME/BizSecureDemo-22180074.git
git branch -M main
git push -u origin main
```

When asked for credentials, use your GitHub username and a **Personal Access Token** (not your password). Create one at: GitHub → Settings → Developer settings → Personal access tokens.

---

## 8. Later: push new changes

After you change code:

```bash
git add .
git status
git commit -m "Describe what you changed"
git push
```

---

## Summary

| Step | Command / action |
|------|-------------------|
| 1 | `cd` to folder with `.sln` and `.gitignore` |
| 2 | `git init` |
| 3 | `git add .` |
| 4 | `git status` (check no bin/obj/.vs) |
| 5 | `git commit -m "Initial commit"` |
| 6 | Create empty repo on GitHub in browser |
| 7 | `git remote add origin <url>`, `git branch -M main`, `git push -u origin main` |
