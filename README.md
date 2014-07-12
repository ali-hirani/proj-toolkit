proj-toolkit
============

Basic Git Bash Commands:

git clone "repoURL"-
//initial import of entire cloud report into local folder

git log
//lists the commits made in that repository in reverse chronological order
//includes Author, Date and author's comment

git log --oneline
//Only author comments

git pull
//pulls from cloud repo to local repo

#Three below steps is the standard process to push changes to cloud repo:

git add -A
//does 2 below operations at once, add to index all files
	git add .
	//add to index only files created/modified and not those deleted
	git add -u
	//add to index only files deleted/modified and not those created

git commit -m "message"
//stamps a commit in the repo log

git push
//pushes changes to cloud repo

git reset --hard