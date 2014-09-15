proj-toolkit
============

##Basic Git Bash Commands:

**git clone "repoURL"-**

initial import of entire cloud report into local folder

**git log** lists the commits made in that repository in reverse chronological order

includes Author, Date and author's comment

**git log --oneline** only includes author comments

**git pull**
pulls from cloud repo to local repo

**git reset --hard**

####How to push all changes to cloud repo

1. **git add -A**
Add to index all files

2. **git commit -m "message"**
stamps a commit in the repo log

3. **git push**
pushes changes to cloud repo


Extra Notes:

#####"git add -A" does the 2 operations below:

1. **git add .**
add to index only files created/modified and not those deleted

2. **git add -u**
add to index only files deleted/modified and not those created

creating a file called .gitignore
>git status