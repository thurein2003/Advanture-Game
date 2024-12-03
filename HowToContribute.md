# Steps to Contribute to the Adventure Game Repository

Follow these steps to contribute to the project:

---

## Step 1: Fork the Repository
1. Go to the Adventure Game repository:  
   [https://github.com/thurein2003/Advanture-Game](https://github.com/thurein2003/Advanture-Game).
2. Click the **Fork** button at the top-right corner to create a copy of the repository in your account.

---

## Step 2: Clone Your Fork
1. Open your forked repository on GitHub.
2. Click the green **Code** button and copy the URL.
3. Clone the repository using the terminal:
   ```bash
   git clone <YOUR_FORKED_REPOSITORY_URL>
   
## Step 3: Set Upstream Remote

```bash
# Add the original repository as the upstream remote
git remote add upstream https://github.com/thurein2003/Advanture-Game.git

# Verify the remotes
git remote -v
```

---

## Step 4: Create a New Branch

```bash
# Create a branch for your changes
git checkout -b feature/<YOUR-FEATURE-NAME>
# Replace <YOUR-FEATURE-NAME> with a descriptive name for your branch.
```

---

## Step 5: Make Changes

```bash
# Open the project in your preferred editor
# Make changes, add features, or fix bugs
# Save your work and test thoroughly
```

---

## Step 6: Commit Changes

```bash
# Stage and commit your changes
git add .
git commit -m "Describe your changes briefly"
```

---

## Step 7: Push Changes

```bash
# Push your branch to your fork
git push origin feature/<YOUR-FEATURE-NAME>
```

---

## Step 8: Create a Pull Request

```bash
# Go to your forked repository on GitHub
# Click the Compare & pull request button
# Provide a clear title and description of your changes
# Submit the pull request
```

---

## Step 9: Address Feedback

```bash
# Respond to any comments or requested changes from reviewers
# Make updates if needed
git add .
git commit -m "Address reviewer feedback"
git push origin feature/<YOUR-FEATURE-NAME>
```

---

## Step 10: Keep Your Fork Updated

```bash
# Fetch changes from the original repository
git fetch upstream

# Merge updates into your local main branch
git checkout main
git merge upstream/main

# Push updates to your fork
git push origin main
```
