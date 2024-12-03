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
Navigate into the project directory:
bash
Copy code
cd Advanture-Game
Step 3: Set Upstream Remote
Add the original repository as the upstream remote to keep your fork updated:

bash
Copy code
git remote add upstream https://github.com/thurein2003/Advanture-Game.git
Verify the remotes:

bash
Copy code
git remote -v
Step 4: Create a New Branch
Create a branch for your changes:

bash
Copy code
git checkout -b feature/<YOUR-FEATURE-NAME>
Replace <YOUR-FEATURE-NAME> with a descriptive name for your branch.

Step 5: Make Changes
Open the project in your preferred editor.
Make changes, add features, or fix bugs.
Save your work and test thoroughly.
Step 6: Commit Changes
Stage and commit your changes:

bash
Copy code
git add .
git commit -m "Describe your changes briefly"
Step 7: Push Changes
Push your branch to your fork:

bash
Copy code
git push origin feature/<YOUR-FEATURE-NAME>
Step 8: Create a Pull Request
Go to your forked repository on GitHub.
Click the Compare & pull request button.
Provide a clear title and description of your changes.
Submit the pull request.
Step 9: Address Feedback
Respond to any comments or requested changes from reviewers.
Make updates if needed:
bash
Copy code
git add .
git commit -m "Address reviewer feedback"
git push origin feature/<YOUR-FEATURE-NAME>
Step 10: Keep Your Fork Updated
Fetch changes from the original repository:
bash
Copy code
git fetch upstream
Merge updates into your local main branch:
bash
Copy code
git checkout main
git merge upstream/main
Push updates to your fork:
bash
Copy code
git push origin main
