function [ outputPath ] = RandInsert( path, num )
%RANDINSERT Summary of this function goes here
%   Detailed explanation goes here
    for n = 1 : num
        s = size(path,1);
        ro = randi(s);
        rn = randi(s);
        insertRow = path(ro);
        newPath = path;
        newPath(ro) = [];
        newPath = [newPath(1:rn-1); insertRow; newPath(rn:end)];
    end 
    outputPath = newPath;
end

